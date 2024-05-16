// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class RefreshObjectCachesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to refresh resources in a directory if the resources are different from the resources in the same directory in the origin server. Default value: false.
        /// 
        /// *   **true**: refresh all resources in the directory.
        /// *   **false**: refresh the changed resources in the directory.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// The type of the object that you want to refresh. Valid values:
        /// 
        /// *   **File** (default): refreshes one or more files.
        /// *   **Directory**: refreshes the files in one or more directories.
        /// *   **Regex**: refreshes content based on regular expressions.
        /// *   **ExQuery**: omits parameters after the question mark in the URL and refreshes content.
        /// 
        /// If you set the ObjectType parameter to File or Directory, you can view [Refresh and prefetch resources](https://help.aliyun.com/document_detail/27140.html) to obtain more information. If you set the ObjectType parameter to Regex, you can view [Configure URL refresh rules that contain regular expressions](https://help.aliyun.com/document_detail/146195.html) to obtain more information.
        /// 
        /// If you set the ObjectType parameter to Directory, the resources in the directory that you want to refresh are marked as expired. You cannot delete the directory. If clients request resources on POPs that are marked as expired, Alibaba Cloud CDN checks whether the resources on your origin server are updated. If resources are updated, Alibaba Cloud CDN retrieves the latest version of the resources and returns the resources to the clients. Otherwise, the origin server returns the 304 status code.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
