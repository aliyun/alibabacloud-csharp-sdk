// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateAlertRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configurations of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public AlertConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is alert</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The scheduling settings of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
