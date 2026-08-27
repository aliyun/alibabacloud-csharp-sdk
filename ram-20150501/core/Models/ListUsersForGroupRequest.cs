// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListUsersForGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The marker. If the response is truncated, you can use this parameter to obtain the content that starts from the position after the truncation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. If the response is truncated because it reaches the <c>MaxItems</c> limit, the <c>IsTruncated</c> response parameter is set to <c>true</c>.</para>
        /// <para>Valid values: 1 to 1000. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

    }

}
