// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The quality inspection task information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityProjectDetailResponseBodyData Data { get; set; }
        public class GetQualityProjectDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The check frequency type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Periodic quality inspection.</description></item>
            /// <item><description><b>4</b>: Ad-hoc quality inspection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckFreqType")]
            [Validation(Required=false)]
            public int? CheckFreqType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-07 18:07:18</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The quality inspection sampling scope.</para>
            /// </summary>
            [NameInMap("DepList")]
            [Validation(Required=false)]
            public List<long?> DepList { get; set; }

            /// <summary>
            /// <para>The quality inspection sampling scope.</para>
            /// </summary>
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<long?> GroupList { get; set; }

            /// <summary>
            /// <para>The ID of the quality inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15977801</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-07 18:07:19</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the quality inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automated quality inspection task</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The IDs of the quality inspection rules.</para>
            /// </summary>
            [NameInMap("QualityRuleIds")]
            [Validation(Required=false)]
            public List<long?> QualityRuleIds { get; set; }

            /// <summary>
            /// <para>The quality inspection type. The value is fixed to <b>1</b> (consulting).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QualityType")]
            [Validation(Required=false)]
            public int? QualityType { get; set; }

            /// <summary>
            /// <para>The quality inspection sampling scope.</para>
            /// </summary>
            [NameInMap("ServicerList")]
            [Validation(Required=false)]
            public List<long?> ServicerList { get; set; }

            /// <summary>
            /// <para>The status of the quality inspection task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Started.</description></item>
            /// <item><description><b>1</b>: Stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The version number of the quality inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
