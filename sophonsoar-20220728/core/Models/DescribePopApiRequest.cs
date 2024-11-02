// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiRequest : TeaModel {
        /// <summary>
        /// <para>The operation name of the Alibaba Cloud service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DescribeInstanceInfo</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The version number of the API.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePopApiVersionList~~">DescribePopApiVersionList</a> operation to query the version number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The environment in which the API operation parameter is used. Set the value to online.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The POP code of the Alibaba Cloud service.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeApiList~~">DescribeApiList</a> operation to query the POP code.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sas</para>
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

    }

}
