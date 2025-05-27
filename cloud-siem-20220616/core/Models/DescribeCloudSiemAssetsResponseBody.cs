// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemAssetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudSiemAssetsResponseBodyData Data { get; set; }
        public class DescribeCloudSiemAssetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeCloudSiemAssetsResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeCloudSiemAssetsResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeCloudSiemAssetsResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeCloudSiemAssetsResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The UUID of the alert associated with the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account in SIEM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1276085894174392</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <para>The logical ID of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0616caeb-acb8-45e0-8520-4ee5fbe251f0</para>
                /// </summary>
                [NameInMap("AssetId")]
                [Validation(Required=false)]
                public string AssetId { get; set; }

                /// <summary>
                /// <para>The display information of the asset is in the JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;KeyName&quot;: &quot;${aliyun.siem.asset.asset_name}&quot;,&quot;Values&quot;: &quot;zsw-agentless-ubuntu20&quot;,&quot;Key&quot;: &quot;asset_name&quot;}]</para>
                /// </summary>
                [NameInMap("AssetInfo")]
                [Validation(Required=false)]
                public List<DescribeCloudSiemAssetsResponseBodyDataResponseDataAssetInfo> AssetInfo { get; set; }
                public class DescribeCloudSiemAssetsResponseBodyDataResponseDataAssetInfo : TeaModel {
                    /// <summary>
                    /// <para>The attribute key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>suspicious.wbd.wb.trojanpath</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The name of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Trojan Path</para>
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// <para>The value of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/root/test33.php</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                /// <summary>
                /// <para>The name of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zsw-agentless-centos****</para>
                /// </summary>
                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                /// <summary>
                /// <para>The type of the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ip</description></item>
                /// <item><description>domain</description></item>
                /// <item><description>url</description></item>
                /// <item><description>process</description></item>
                /// <item><description>file</description></item>
                /// <item><description>host</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The cloud code of the entity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>aliyun: Alibaba Cloud</description></item>
                /// <item><description>qcloud: Tencent Cloud</description></item>
                /// <item><description>hcloud: Huawei Cloud</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// <para>The time when the asset was synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the asset was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The UUID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>The ID of the associated account to which the asset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
