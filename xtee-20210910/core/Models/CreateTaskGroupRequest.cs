// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateTaskGroupRequest : TeaModel {
        /// <summary>
        /// <para>The language of the error message returned by the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The sample IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("SampleIds")]
        [Validation(Required=false)]
        public string SampleIds { get; set; }

        /// <summary>
        /// <para>The scenarios corresponding to the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;porn\&quot;,\&quot;terrorism\&quot;,\&quot;ad\&quot;]</para>
        /// </summary>
        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

        /// <summary>
        /// <para>The service codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ServiceCodes")]
        [Validation(Required=false)]
        public string ServiceCodes { get; set; }

        /// <summary>
        /// <para>The service list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;serviceCode&quot;:&quot;anti_fraud_v4_score&quot;},{&quot;serviceCode&quot;:&quot;antif2_score&quot;},{&quot;serviceCode&quot;:&quot;anti_fraud_customed&quot;,&quot;scenes&quot;:[&quot;TC_general_1&quot;,&quot;aliyun_cust_feat_all&quot;]},{&quot;serviceCode&quot;:&quot;antif2_customed_plus&quot;,&quot;scenes&quot;:[&quot;antif2_customed_v1_feature&quot;]}]</para>
        /// </summary>
        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public string ServiceList { get; set; }

        /// <summary>
        /// <para>The list of service names for per-application statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ServiceNames")]
        [Validation(Required=false)]
        public string ServiceNames { get; set; }

        /// <summary>
        /// <para>The scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

        /// <summary>
        /// <para>The task group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TeskGroupTest</para>
        /// </summary>
        [NameInMap("TaskGroupName")]
        [Validation(Required=false)]
        public string TaskGroupName { get; set; }

        /// <summary>
        /// <para>The access type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAF_CONSOLE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
