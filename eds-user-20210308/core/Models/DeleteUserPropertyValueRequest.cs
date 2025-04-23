// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DeleteUserPropertyValueRequest : TeaModel {
        /// <summary>
        /// <para>The property ID. You can call the <a href="~~ListProperty~~">ListProperty</a> operation to query the property ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>390</para>
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// <para>The property value ID. You can call the <a href="~~ListProperty~~">ListProperty</a> operation to query the property value ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>978</para>
        /// </summary>
        [NameInMap("PropertyValueId")]
        [Validation(Required=false)]
        public long? PropertyValueId { get; set; }

        /// <summary>
        /// <para>The user ID. You can call the <a href="~~DescribeUsers~~">DescribeUsers</a> operation to query the user ID, which is the return value of the <c>Id</c> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
