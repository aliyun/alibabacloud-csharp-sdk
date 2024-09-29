// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the alert contact group.</para>
        /// </summary>
        [NameInMap("AlertContactGroup")]
        [Validation(Required=false)]
        public CreateOrUpdateContactGroupResponseBodyAlertContactGroup AlertContactGroup { get; set; }
        public class CreateOrUpdateContactGroupResponseBodyAlertContactGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the alert contact group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ContactGroupId")]
            [Validation(Required=false)]
            public float? ContactGroupId { get; set; }

            /// <summary>
            /// <para>The name of the alert contact group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup</para>
            /// </summary>
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// <para>The IDs of the contacts that are included in the alert contact group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[1,2,3]</para>
            /// </summary>
            [NameInMap("ContactIds")]
            [Validation(Required=false)]
            public string ContactIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9319A57D-2D9E-472A-B69B-CF3CD16D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
