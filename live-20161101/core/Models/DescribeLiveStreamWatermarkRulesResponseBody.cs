// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamWatermarkRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b9676b3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The watermark rules.</para>
        /// </summary>
        [NameInMap("RuleInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoList RuleInfoList { get; set; }
        public class DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoList : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoListRuleInfo> RuleInfo { get; set; }
            public class DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoListRuleInfo : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                /// <summary>
                /// <para>The description of the custom rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my rule</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The name of the custom rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WatermarkRule****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the watermark rule.</para>
                /// <remarks>
                /// <para> You can obtain the rule ID by checking the value of the RuleId parameter that is returned by the <a href="https://help.aliyun.com/document_detail/2848100.html">AddLiveStreamWatermarkRule</a> operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>445409ec-7eaa-461d -8f29-4bec2eb9****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the live stream. The following matching rules apply:</para>
                /// <list type="bullet">
                /// <item><description>A stream name can be exactly matched. Example: liveStreamA.</description></item>
                /// <item><description>Fuzzy match is also supported. The use of an asterisk (<c>*</c>) allows all approximate matches to be found.</description></item>
                /// <item><description>You can place the asterisk before or after an approximate string.</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>Fuzzy match: Only one asterisk (<c>*</c>) before or after an approximate string is allowed. The approximate string must be enclosed in <c>()</c>. Separate multiple strings with vertical bars (<c>|</c>).</para>
                /// </description></item>
                /// <item><description><para>For example, <c>*(t1|t2)</c> matches all streams whose name has the <c>t1</c> or <c>t2</c> suffix, and <c>(abc|123)*</c> matches all streams whose name has the <c>abc</c> or <c>123</c> prefix.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>liveStreamA</para>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

                /// <summary>
                /// <para>The ID of the watermark template.</para>
                /// <remarks>
                /// <para> You can obtain the template ID by checking the value of the TemplateId parameter that is returned by the <a href="https://help.aliyun.com/document_detail/2848096.html">AddLiveStreamWatermark</a> operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>445409ec-7eaa-461d-8f29-4bec2eb9 ****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
