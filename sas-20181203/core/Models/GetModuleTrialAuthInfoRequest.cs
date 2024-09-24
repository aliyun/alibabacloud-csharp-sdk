// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetModuleTrialAuthInfoRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The code of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vulFix</b>: vulnerability fixing.</description></item>
        /// <item><description><b>cloudSiem</b>: threat analysis and response.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vulFix</para>
        /// </summary>
        [NameInMap("ModuleCode")]
        [Validation(Required=false)]
        public string ModuleCode { get; set; }

    }

}
