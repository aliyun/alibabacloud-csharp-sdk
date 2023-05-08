// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAssetsPropertyDetailResponseBodyPageInfo PageInfo { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// An array that consists of the details about the asset fingerprints.
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailResponseBodyPropertys> Propertys { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// The name of the container.
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// The timestamp of the last fingerprint collection. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The domain name of the website.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The path to the kernel module file.
            /// 
            /// > This parameter is returned only when **Biz** is set to **lkm**.
            /// </summary>
            [NameInMap("Filepath")]
            [Validation(Required=false)]
            public string Filepath { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The IP address of the server.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The listening protocol that the website uses.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("ListenProtocol")]
            [Validation(Required=false)]
            public string ListenProtocol { get; set; }

            /// <summary>
            /// The name of the module.
            /// 
            /// > This parameter is returned only when **Biz** is set to **lkm**.
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// The path. The value of this parameter varies based on the value of **Biz**.
            /// 
            /// *   If **Biz** is set to **web_server**, the value of this parameter indicates the path to the website root directory.
            /// *   If **Biz** is set to **autorun**, the value of this parameter indicates the path to the startup item.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The permissions on the root directory of the website.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("PathMode")]
            [Validation(Required=false)]
            public string PathMode { get; set; }

            /// <summary>
            /// The process ID (PID) of the process that runs the website service.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The port of the website.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The timestamp when the process was started. Unit: milliseconds.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("ProcessStarted")]
            [Validation(Required=false)]
            public long? ProcessStarted { get; set; }

            /// <summary>
            /// The ID of the region in which the server resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type of the website.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// The size of the kernel module.
            /// 
            /// > This parameter is returned only when **Biz** is set to **lkm**.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The number of times that the kernel module is referenced.
            /// 
            /// > This parameter is returned only when **Biz** is set to **lkm**.
            /// </summary>
            [NameInMap("UsedByCount")]
            [Validation(Required=false)]
            public int? UsedByCount { get; set; }

            /// <summary>
            /// The user who started the process of the website.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The path to the root directory of the website.
            /// 
            /// > This parameter is returned only when **Biz** is set to **web_server**.
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
