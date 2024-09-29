// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListScenarioRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b590lhguqs@28f515462******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the business monitoring job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro-content</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjaikou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scenario where the business monitoring job is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>USER-DEFINED</c>: user-defined. This is the default value.</description></item>
        /// <item><description><c>EDAS-ROLLOUT</c>: application release in Enterprise Distributed Application Service (EDAS)</description></item>
        /// <item><description><c>OAM-ROLLOUT</c>: application release based on Open Application Model (OAM)</description></item>
        /// <item><description><c>MSC-CANARY</c>: canary release based on Microservice Engine (MSE)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER-DEFINED</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The code of the business monitoring job. Set this parameter when you know the code of the business monitoring job you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9f8****</para>
        /// </summary>
        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

    }

}
