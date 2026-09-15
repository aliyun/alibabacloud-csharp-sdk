// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The request struct for updating a template. Specify only the fields that you want to change.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PublicUpdateTemplateInput Body { get; set; }

        /// <summary>
        /// <para>The team ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
