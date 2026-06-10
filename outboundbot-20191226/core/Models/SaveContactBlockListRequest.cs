// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveContactBlockListRequest : TeaModel {
        /// <summary>
        /// <para>The list of contacts. [Deprecated]</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ContactBlockListList")]
        [Validation(Required=false)]
        public List<string> ContactBlockListList { get; set; }

        /// <summary>
        /// <para>A JSON string that contains the blocklist. This parameter is required.</para>
        /// <list type="bullet">
        /// <item><description><para>phoneNumber: The mobile phone number.</para>
        /// </description></item>
        /// <item><description><para>remark: The remarks.</para>
        /// </description></item>
        /// <item><description><para>name: The name.</para>
        /// </description></item>
        /// <item><description><para>creator: The creator.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;phoneNumber&quot;:&quot;132322&quot;,&quot;remark&quot;:&quot;123321&quot;,&quot;name&quot;:&quot;ccc1&quot;,&quot;creator&quot;:&quot;ccc222&quot;}]</para>
        /// </summary>
        [NameInMap("ContactBlockListsJson")]
        [Validation(Required=false)]
        public string ContactBlockListsJson { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3c92de8-e4bd-4db4-a962-50f8acce40bc</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
