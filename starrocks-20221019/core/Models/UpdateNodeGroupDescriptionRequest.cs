// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class UpdateNodeGroupDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>The description of the compute group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>okcc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the compute group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3d5ce6454354****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The RAM authorization information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Optional</para>
        /// </summary>
        [NameInMap("X-Acs-Ram-Auth-Context")]
        [Validation(Required=false)]
        public string XAcsRamAuthContext { get; set; }

    }

}
