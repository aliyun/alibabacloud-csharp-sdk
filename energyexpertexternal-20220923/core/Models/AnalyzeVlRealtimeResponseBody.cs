// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AnalyzeVlRealtimeResponseBody : TeaModel {
        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AnalyzeVlRealtimeResponseBodyData Data { get; set; }
        public class AnalyzeVlRealtimeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Document parsing result details</para>
            /// </summary>
            [NameInMap("kvListInfo")]
            [Validation(Required=false)]
            public List<AnalyzeVlRealtimeResponseBodyDataKvListInfo> KvListInfo { get; set; }
            public class AnalyzeVlRealtimeResponseBodyDataKvListInfo : TeaModel {
                /// <summary>
                /// <para>Recall content</para>
                /// </summary>
                [NameInMap("context")]
                [Validation(Required=false)]
                public AnalyzeVlRealtimeResponseBodyDataKvListInfoContext Context { get; set; }
                public class AnalyzeVlRealtimeResponseBodyDataKvListInfoContext : TeaModel {
                    /// <summary>
                    /// <para>Confidence</para>
                    /// </summary>
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public AnalyzeVlRealtimeResponseBodyDataKvListInfoContextConfidence Confidence { get; set; }
                    public class AnalyzeVlRealtimeResponseBodyDataKvListInfoContextConfidence : TeaModel {
                        /// <summary>
                        /// <para>Key confidence</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.9994202852249146</para>
                        /// </summary>
                        [NameInMap("keyConfidence")]
                        [Validation(Required=false)]
                        public double? KeyConfidence { get; set; }

                        /// <summary>
                        /// <para>Value confidence</para>
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
                    /// <para>Value recall information details</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public List<ContentItem> Value { get; set; }

                }

                /// <summary>
                /// <para>Field Key name</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("keyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>Field key value</para>
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
