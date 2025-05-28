// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqQueryAbilityRequest : TeaModel {
        /// <summary>
        /// <para>Dataset ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// <remarks>
        /// <para>Notice: If this field is not filled, the data will be queried by default as the organization owner.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Question text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This year\&quot;s sales data</para>
        /// </summary>
        [NameInMap("UserQuestion")]
        [Validation(Required=false)]
        public string UserQuestion { get; set; }

    }

}
