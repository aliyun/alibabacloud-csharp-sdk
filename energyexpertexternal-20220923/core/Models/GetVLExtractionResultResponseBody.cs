// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetVLExtractionResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned Data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetVLExtractionResultResponseBodyData Data { get; set; }
        public class GetVLExtractionResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Document Parsing Result</para>
            /// </summary>
            [NameInMap("kvListInfo")]
            [Validation(Required=false)]
            public List<GetVLExtractionResultResponseBodyDataKvListInfo> KvListInfo { get; set; }
            public class GetVLExtractionResultResponseBodyDataKvListInfo : TeaModel {
                /// <summary>
                /// <para>Recall content</para>
                /// </summary>
                [NameInMap("context")]
                [Validation(Required=false)]
                public GetVLExtractionResultResponseBodyDataKvListInfoContext Context { get; set; }
                public class GetVLExtractionResultResponseBodyDataKvListInfoContext : TeaModel {
                    /// <summary>
                    /// <para>Confidence</para>
                    /// </summary>
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public GetVLExtractionResultResponseBodyDataKvListInfoContextConfidence Confidence { get; set; }
                    public class GetVLExtractionResultResponseBodyDataKvListInfoContextConfidence : TeaModel {
                        /// <summary>
                        /// <para>Confidence of Key</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9994202852249146</para>
                        /// </summary>
                        [NameInMap("keyConfidence")]
                        [Validation(Required=false)]
                        public double? KeyConfidence { get; set; }

                        /// <summary>
                        /// <para>Confidence of Value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9794202852249146</para>
                        /// </summary>
                        [NameInMap("valueConfidence")]
                        [Validation(Required=false)]
                        public double? ValueConfidence { get; set; }

                    }

                    /// <summary>
                    /// <para>Key recall information details</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public List<ContentItem> Key { get; set; }

                    /// <summary>
                    /// <para>Value Recall Information</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public List<ContentItem> Value { get; set; }

                }

                /// <summary>
                /// <para>Field Key name</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tenant</para>
                /// </summary>
                [NameInMap("keyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>Field key value</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud XXX Co., Ltd.</para>
                /// </summary>
                [NameInMap("keyValue")]
                [Validation(Required=false)]
                public string KeyValue { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
