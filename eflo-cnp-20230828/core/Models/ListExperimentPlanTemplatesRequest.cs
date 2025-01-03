// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ListExperimentPlanTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The sharing level of the template, default is private, options are public and private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("PrivacyLevel")]
        [Validation(Required=false)]
        public string PrivacyLevel { get; set; }

    }

}
