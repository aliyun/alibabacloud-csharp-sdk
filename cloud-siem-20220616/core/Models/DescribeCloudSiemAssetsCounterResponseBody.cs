// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemAssetsCounterResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCloudSiemAssetsCounterResponseBodyData> Data { get; set; }
        public class DescribeCloudSiemAssetsCounterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetNum")]
            [Validation(Required=false)]
            public int? AssetNum { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ip: IP address</para>
            /// </description></item>
            /// <item><description><para>domain: domain name</para>
            /// </description></item>
            /// <item><description><para>url: URL</para>
            /// </description></item>
            /// <item><description><para>process: process</para>
            /// </description></item>
            /// <item><description><para>file: file</para>
            /// </description></item>
            /// <item><description><para>host: host</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
