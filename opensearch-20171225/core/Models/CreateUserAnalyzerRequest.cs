// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateUserAnalyzerRequest : TeaModel {
        /// <summary>
        /// <para>The basic analyzer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chn_standard</para>
        /// </summary>
        [NameInMap("business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        /// <summary>
        /// <para>The application ID of the custom analyzer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110123123</para>
        /// </summary>
        [NameInMap("businessAppGroupId")]
        [Validation(Required=false)]
        public string BusinessAppGroupId { get; set; }

        /// <summary>
        /// <para>The basic analyzer type. Valid values: AUTO, MODEL, SYSTEM, and USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("businessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The analyzer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jmbon_analyzer</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values: HA3 and ES.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HA3</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Default value: false.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
