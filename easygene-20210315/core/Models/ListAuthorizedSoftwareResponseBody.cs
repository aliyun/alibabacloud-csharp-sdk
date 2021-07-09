// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListAuthorizedSoftwareResponseBody : TeaModel {
        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// 翻页TOKEN
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 软件信息
        /// </summary>
        [NameInMap("Softwares")]
        [Validation(Required=false)]
        public List<ListAuthorizedSoftwareResponseBodySoftwares> Softwares { get; set; }
        public class ListAuthorizedSoftwareResponseBodySoftwares : TeaModel {
            /// <summary>
            /// 软件名称
            /// </summary>
            [NameInMap("SoftwareName")]
            [Validation(Required=false)]
            public string SoftwareName { get; set; }

            /// <summary>
            /// 软件长名称
            /// </summary>
            [NameInMap("SoftwareLongName")]
            [Validation(Required=false)]
            public string SoftwareLongName { get; set; }

            /// <summary>
            /// 软件描述
            /// </summary>
            [NameInMap("SoftwareDescription")]
            [Validation(Required=false)]
            public string SoftwareDescription { get; set; }

            /// <summary>
            /// 软件默认版本
            /// </summary>
            [NameInMap("SoftwareDefaultVersion")]
            [Validation(Required=false)]
            public string SoftwareDefaultVersion { get; set; }

            /// <summary>
            /// 软件所有版本
            /// </summary>
            [NameInMap("SoftwareVersions")]
            [Validation(Required=false)]
            public List<string> SoftwareVersions { get; set; }

            /// <summary>
            /// 软件使用费用
            /// </summary>
            [NameInMap("SoftwareLicenseFee")]
            [Validation(Required=false)]
            public float? SoftwareLicenseFee { get; set; }

            /// <summary>
            /// 软件可用区域
            /// </summary>
            [NameInMap("RegionIds")]
            [Validation(Required=false)]
            public List<string> RegionIds { get; set; }

            /// <summary>
            /// 帮助链接
            /// </summary>
            [NameInMap("HelpLink")]
            [Validation(Required=false)]
            public string HelpLink { get; set; }

            /// <summary>
            /// 软件图标链接
            /// </summary>
            [NameInMap("SoftwareIcon")]
            [Validation(Required=false)]
            public string SoftwareIcon { get; set; }

            /// <summary>
            /// 最后更新时间
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

        }

    }

}
