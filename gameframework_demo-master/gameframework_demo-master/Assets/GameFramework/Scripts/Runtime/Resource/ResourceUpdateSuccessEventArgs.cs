//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework.Event;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 资源更新成功事件。
    /// </summary>
    public sealed class ResourceUpdateSuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 资源更新成功事件编号。
        /// </summary>
        public static readonly int EventId = typeof(ResourceUpdateSuccessEventArgs).GetHashCode();

        /// <summary>
        /// 获取资源更新成功事件编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取资源名称。
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源下载后存放路径。
        /// </summary>
        public string DownloadPath
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取下载地址。
        /// </summary>
        public string DownloadUri
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源大小。
        /// </summary>
        public int Length
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取压缩包大小。
        /// </summary>
        public int ZipLength
        {
            get;
            private set;
        }

        /// <summary>
        /// 清理资源更新成功事件。
        /// </summary>
        public override void Clear()
        {
            Name = default(string);
            DownloadPath = default(string);
            DownloadUri = default(string);
            Length = default(int);
            ZipLength = default(int);
        }

        /// <summary>
        /// 填充资源更新成功事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>资源更新成功事件。</returns>
        public ResourceUpdateSuccessEventArgs Fill(GameFramework.Resource.ResourceUpdateSuccessEventArgs e)
        {
            Name = e.Name;
            DownloadPath = e.DownloadPath;
            DownloadUri = e.DownloadUri;
            Length = e.Length;
            ZipLength = e.ZipLength;

            return this;
        }
    }
}
