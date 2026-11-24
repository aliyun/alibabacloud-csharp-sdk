// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetProhibitedSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the prohibited software.</para>
        /// </summary>
        [NameInMap("SoftwareId")]
        [Validation(Required=false)]
        public GetProhibitedSoftwareRequestSoftwareId SoftwareId { get; set; }
        public class GetProhibitedSoftwareRequestSoftwareId : TeaModel {
            /// <summary>
            /// <para>Specifies whether the prohibited software is a built-in prohibited software. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The software is a built-in prohibited software. It is shared by all Alibaba Cloud accounts and cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: The software is a custom prohibited software within the current Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software. You can obtain the value from the following operations:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~ListProhibitedSoftware~~">ListProhibitedSoftware</a>: Queries prohibited software in batches.</description></item>
            /// <item><description><a href="~~CreateProhibitedSoftware~~">CreateProhibitedSoftware</a>: Creates custom prohibited software.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>swb-3e6a1f9c4b28****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

        }

    }

}
