// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUpdateDesensStatusListRequest : TeaModel {
        /// <summary>
        /// <para>The switch status. Valid values:
        /// 1: enabled
        /// 0: disabled</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DesensStatus")]
        [Validation(Required=false)]
        public int? DesensStatus { get; set; }

        /// <summary>
        /// <para>The list of switch IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<int?> Ids { get; set; }

    }

}
