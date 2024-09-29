// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListScenarioResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information of the business monitoring job.</para>
        /// </summary>
        [NameInMap("ArmsScenarios")]
        [Validation(Required=false)]
        public List<ListScenarioResponseBodyArmsScenarios> ArmsScenarios { get; set; }
        public class ListScenarioResponseBodyArmsScenarios : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b590lhguqs@28f515462******</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the business monitoring job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1585214916000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The extended information. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;_MODE&quot;: &quot;CUSTOM-TRANSACTION&quot;,&quot;_SCENARIO&quot;: &quot;USER-DEFINED&quot;}</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public string Extensions { get; set; }

            /// <summary>
            /// <para>The ID of the business monitoring job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the business monitoring job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s_deployment_css-guns-vip-main-prod_silence</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The code of the business monitoring job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a9f8****</para>
            /// </summary>
            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            /// <summary>
            /// <para>The time when the business monitoring job was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1585214916000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113197164949****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98027D1F-3AEB-492C-A4AA-E9217992****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
