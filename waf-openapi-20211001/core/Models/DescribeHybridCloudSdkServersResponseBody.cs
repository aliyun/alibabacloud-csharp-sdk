// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudSdkServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600F008-2E76-5D0B-BC76-EFBD****6D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the hybrid cloud SDK servers.</para>
        /// </summary>
        [NameInMap("SdkServers")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudSdkServersResponseBodySdkServers> SdkServers { get; set; }
        public class DescribeHybridCloudSdkServersResponseBodySdkServers : TeaModel {
            /// <summary>
            /// <para>The name of the hybrid cloud cluster to which the SDK server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testcluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The time when the hybrid cloud SDK server was created. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621428205000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The hostname of the hybrid cloud SDK server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qsh5-sec-8-fedd**005</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The IP address of the hybrid cloud SDK server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The ID of the SDK server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b11327c21790846374051d5d**83c</para>
            /// </summary>
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }

            /// <summary>
            /// <para>The address of the protection group associated with the SDK server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("ProtectionGroupAddress")]
            [Validation(Required=false)]
            public string ProtectionGroupAddress { get; set; }

            /// <summary>
            /// <para>Indicates whether traffic redirection is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: Traffic redirection is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: Traffic redirection is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PullinStatus")]
            [Validation(Required=false)]
            public string PullinStatus { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-antifaud-2.jqt.wafqax.top-waf</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The status of the hybrid cloud SDK server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the hybrid cloud SDK server was last updated. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719489906000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of hybrid cloud SDK servers returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
