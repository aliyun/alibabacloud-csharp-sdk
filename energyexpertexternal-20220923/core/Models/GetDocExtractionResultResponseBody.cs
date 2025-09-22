// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDocExtractionResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data structure.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocExtractionResultResponseBodyData Data { get; set; }
        public class GetDocExtractionResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details of document extraction results</para>
            /// </summary>
            [NameInMap("kvListInfo")]
            [Validation(Required=false)]
            public List<GetDocExtractionResultResponseBodyDataKvListInfo> KvListInfo { get; set; }
            public class GetDocExtractionResultResponseBodyDataKvListInfo : TeaModel {
                /// <summary>
                /// <para>Recalled content</para>
                /// </summary>
                [NameInMap("context")]
                [Validation(Required=false)]
                public GetDocExtractionResultResponseBodyDataKvListInfoContext Context { get; set; }
                public class GetDocExtractionResultResponseBodyDataKvListInfoContext : TeaModel {
                    /// <summary>
                    /// <para>Confidence level</para>
                    /// </summary>
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public GetDocExtractionResultResponseBodyDataKvListInfoContextConfidence Confidence { get; set; }
                    public class GetDocExtractionResultResponseBodyDataKvListInfoContextConfidence : TeaModel {
                        /// <summary>
                        /// <para>Key confidence level</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9994202852249146</para>
                        /// </summary>
                        [NameInMap("keyConfidence")]
                        [Validation(Required=false)]
                        public double? KeyConfidence { get; set; }

                        /// <summary>
                        /// <para>value confidence level</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9794202852249146</para>
                        /// </summary>
                        [NameInMap("valueConfidence")]
                        [Validation(Required=false)]
                        public double? ValueConfidence { get; set; }

                    }

                    /// <summary>
                    /// <para>Details of key recall information</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public List<ContentItem> Key { get; set; }

                    /// <summary>
                    /// <para>Details of value recall information</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public List<ContentItem> Value { get; set; }

                }

                /// <summary>
                /// <para>Field key name</para>
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
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
