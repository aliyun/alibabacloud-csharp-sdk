// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class GetSubTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0A519CFA-0EEC-580A-A5C1-F9C653FB2354</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public GetSubTaskResultResponseBodyResultObject ResultObject { get; set; }
        public class GetSubTaskResultResponseBodyResultObject : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<GetSubTaskResultResponseBodyResultObjectConfig> Config { get; set; }
            public class GetSubTaskResultResponseBodyResultObjectConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>repl_lag</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>des</para>
                /// </summary>
                [NameInMap("ItemDesc")]
                [Validation(Required=false)]
                public string ItemDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sample</para>
                /// </summary>
                [NameInMap("SampleItem")]
                [Validation(Required=false)]
                public string SampleItem { get; set; }

                [NameInMap("SampleItems")]
                [Validation(Required=false)]
                public List<string> SampleItems { get; set; }

            }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("File")]
            [Validation(Required=false)]
            public GetSubTaskResultResponseBodyResultObjectFile File { get; set; }
            public class GetSubTaskResultResponseBodyResultObjectFile : TeaModel {
                [NameInMap("Col")]
                [Validation(Required=false)]
                public List<GetSubTaskResultResponseBodyResultObjectFileCol> Col { get; set; }
                public class GetSubTaskResultResponseBodyResultObjectFileCol : TeaModel {
                    /// <summary>
                    /// <para>A0。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A0</para>
                    /// </summary>
                    [NameInMap("A0")]
                    [Validation(Required=false)]
                    public string A0 { get; set; }

                    /// <summary>
                    /// <para>A1。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A1</para>
                    /// </summary>
                    [NameInMap("A1")]
                    [Validation(Required=false)]
                    public string A1 { get; set; }

                    /// <summary>
                    /// <para>A10。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A10</para>
                    /// </summary>
                    [NameInMap("A10")]
                    [Validation(Required=false)]
                    public string A10 { get; set; }

                    /// <summary>
                    /// <para>A11。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A11</para>
                    /// </summary>
                    [NameInMap("A11")]
                    [Validation(Required=false)]
                    public string A11 { get; set; }

                    /// <summary>
                    /// <para>A2。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A2</para>
                    /// </summary>
                    [NameInMap("A2")]
                    [Validation(Required=false)]
                    public string A2 { get; set; }

                    /// <summary>
                    /// <para>A3。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A3</para>
                    /// </summary>
                    [NameInMap("A3")]
                    [Validation(Required=false)]
                    public string A3 { get; set; }

                    /// <summary>
                    /// <para>A4。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A4</para>
                    /// </summary>
                    [NameInMap("A4")]
                    [Validation(Required=false)]
                    public string A4 { get; set; }

                    /// <summary>
                    /// <para>A5。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A5</para>
                    /// </summary>
                    [NameInMap("A5")]
                    [Validation(Required=false)]
                    public string A5 { get; set; }

                    /// <summary>
                    /// <para>A6。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A6</para>
                    /// </summary>
                    [NameInMap("A6")]
                    [Validation(Required=false)]
                    public string A6 { get; set; }

                    /// <summary>
                    /// <para>A7。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A7</para>
                    /// </summary>
                    [NameInMap("A7")]
                    [Validation(Required=false)]
                    public string A7 { get; set; }

                    /// <summary>
                    /// <para>A8。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A8</para>
                    /// </summary>
                    [NameInMap("A8")]
                    [Validation(Required=false)]
                    public string A8 { get; set; }

                    /// <summary>
                    /// <para>A9。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A9</para>
                    /// </summary>
                    [NameInMap("A9")]
                    [Validation(Required=false)]
                    public string A9 { get; set; }

                }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public List<string> Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enorl-20w-0926.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CSV</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>saf/cpoc/34cd7959590ef568086035b956210495/1760580976089_XN_test_1016_100000.csv</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("IsCharge")]
            [Validation(Required=false)]
            public bool? IsCharge { get; set; }

            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<GetSubTaskResultResponseBodyResultObjectLog> Log { get; set; }
            public class GetSubTaskResultResponseBodyResultObjectLog : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PasswordExpired</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1760408725312</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>managed.by.apig</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://shuanglu-prod.oss-cn-shanghai-finance-1-pub.aliyuncs.com/idrs/24/local/remoteresult?Expires=1756436489&OSSAccessKeyId=****&Signature=">http://shuanglu-prod.oss-cn-shanghai-finance-1-pub.aliyuncs.com/idrs/24/local/remoteresult?Expires=1756436489&amp;OSSAccessKeyId=****&amp;Signature=</a>****</para>
            /// </summary>
            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rate</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>anti_fraud_customed_v3</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLASS_CHANGING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19150</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>icekredit_model_A_2025a_508185</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5129547232</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
