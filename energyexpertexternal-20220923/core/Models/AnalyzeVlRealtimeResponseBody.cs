// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AnalyzeVlRealtimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AnalyzeVlRealtimeResponseBodyData Data { get; set; }
        public class AnalyzeVlRealtimeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the document extraction result.</para>
            /// </summary>
            [NameInMap("kvListInfo")]
            [Validation(Required=false)]
            public List<AnalyzeVlRealtimeResponseBodyDataKvListInfo> KvListInfo { get; set; }
            public class AnalyzeVlRealtimeResponseBodyDataKvListInfo : TeaModel {
                /// <summary>
                /// <para>The recalled content.</para>
                /// </summary>
                [NameInMap("context")]
                [Validation(Required=false)]
                public AnalyzeVlRealtimeResponseBodyDataKvListInfoContext Context { get; set; }
                public class AnalyzeVlRealtimeResponseBodyDataKvListInfoContext : TeaModel {
                    /// <summary>
                    /// <para>The confidence level.</para>
                    /// </summary>
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public AnalyzeVlRealtimeResponseBodyDataKvListInfoContextConfidence Confidence { get; set; }
                    public class AnalyzeVlRealtimeResponseBodyDataKvListInfoContextConfidence : TeaModel {
                        /// <summary>
                        /// <para>The confidence level of the key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9994202852249146</para>
                        /// </summary>
                        [NameInMap("keyConfidence")]
                        [Validation(Required=false)]
                        public double? KeyConfidence { get; set; }

                        /// <summary>
                        /// <para>The confidence level of the value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9794202852249146</para>
                        /// </summary>
                        [NameInMap("valueConfidence")]
                        [Validation(Required=false)]
                        public double? ValueConfidence { get; set; }

                    }

                    /// <summary>
                    /// <para>The details of the recalled key information.</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public List<ContentItem> Key { get; set; }

                    /// <summary>
                    /// <para>The details of the recalled value information.</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public List<ContentItem> Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("keyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>The value of the key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bob</para>
                /// </summary>
                [NameInMap("keyValue")]
                [Validation(Required=false)]
                public string KeyValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
