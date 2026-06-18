// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectListResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Quality inspection job information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityProjectListResponseBodyData Data { get; set; }
        public class GetQualityProjectListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>List of quality inspection jobs.</para>
            /// </summary>
            [NameInMap("QualityProjectList")]
            [Validation(Required=false)]
            public List<GetQualityProjectListResponseBodyDataQualityProjectList> QualityProjectList { get; set; }
            public class GetQualityProjectListResponseBodyDataQualityProjectList : TeaModel {
                /// <summary>
                /// <para>Quality inspection job frequency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckFreqType")]
                [Validation(Required=false)]
                public int? CheckFreqType { get; set; }

                /// <summary>
                /// <para>Creation Time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-07 18:07:18</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Quality inspection sampling scope.</para>
                /// </summary>
                [NameInMap("DepList")]
                [Validation(Required=false)]
                public List<long?> DepList { get; set; }

                /// <summary>
                /// <para>Quality inspection sampling scope.</para>
                /// </summary>
                [NameInMap("GroupList")]
                [Validation(Required=false)]
                public List<long?> GroupList { get; set; }

                /// <summary>
                /// <para>Quality inspection job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15977801</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Updated At.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-07 18:07:19</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>Quality inspection job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自动化质检任务</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>Quality inspection rule IDs.</para>
                /// </summary>
                [NameInMap("QualityRuleIds")]
                [Validation(Required=false)]
                public List<long?> QualityRuleIds { get; set; }

                /// <summary>
                /// <para>Quality inspection type. Fixed value is <b>1</b> (Consultation).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QualityType")]
                [Validation(Required=false)]
                public int? QualityType { get; set; }

                /// <summary>
                /// <para>Scope of quality inspection sampling.</para>
                /// </summary>
                [NameInMap("ServicerList")]
                [Validation(Required=false)]
                public List<long?> ServicerList { get; set; }

                /// <summary>
                /// <para>Status of the quality inspection job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Quality inspection job version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
