// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CheckUsedPropertyValueRequest : TeaModel {
        /// <summary>
        /// <para>The property ID. You can call the <a href="~~ListProperty~~">ListProperty</a> operation to query property ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>380</para>
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// <para>The ID of the property value. You can call the <a href="~~ListProperty~~">ListProperty</a> operation to query the ID of the property value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>978</para>
        /// </summary>
        [NameInMap("PropertyValueId")]
        [Validation(Required=false)]
        public long? PropertyValueId { get; set; }

    }

}
