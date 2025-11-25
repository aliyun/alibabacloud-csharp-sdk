// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlEventListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F06DE24D-6EB9-5F55-B588-7BB946DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SdlEventDetailList")]
        [Validation(Required=false)]
        public List<DescribeSdlEventListResponseBodySdlEventDetailList> SdlEventDetailList { get; set; }
        public class DescribeSdlEventListResponseBodySdlEventDetailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.100.102.XXX</para>
            /// </summary>
            [NameInMap("AssetPrivateIp")]
            [Validation(Required=false)]
            public string AssetPrivateIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EIP</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("CategoryClassId")]
            [Validation(Required=false)]
            public string CategoryClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Trusted</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>000</para>
            /// </summary>
            [NameInMap("CityId")]
            [Validation(Required=false)]
            public string CityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>106.14.74.XXX</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("DstPortList")]
            [Validation(Required=false)]
            public string DstPortList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventCnt")]
            [Validation(Required=false)]
            public long? EventCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1735697768</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1738636157</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3082002f02010004067075626c6963a082002002044c33a756020100020100308200103082000c06082b060102010105000500</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("ProtoList")]
            [Validation(Required=false)]
            public string ProtoList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ce347a98f41e849188aa51c56b02a****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResourceIdType")]
            [Validation(Required=false)]
            public int? ResourceIdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SensitiveDataCnt")]
            [Validation(Required=false)]
            public long? SensitiveDataCnt { get; set; }

            [NameInMap("SensitiveDataList")]
            [Validation(Required=false)]
            public List<string> SensitiveDataList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public string SensitiveType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>104.28.226.XX</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("SrcPortList")]
            [Validation(Required=false)]
            public string SrcPortList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TrafficBytes")]
            [Validation(Required=false)]
            public long? TrafficBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b91035dc-8be4-411d-bec5-e6320af9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
