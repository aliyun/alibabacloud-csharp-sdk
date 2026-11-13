// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApplyResourceAccessPermissionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource permission applications.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyContents")]
        [Validation(Required=false)]
        public string ApplyContentsShrink { get; set; }

        /// <summary>
        /// <para>The idempotency token used to prevent duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The reason for the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business development requirements</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
