// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyObjectGroupOperationRequest : TeaModel {
        /// <summary>
        /// <para>The remarks for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The traffic direction that is controlled by the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>in</b>: Inbound traffic.</para>
        /// </description></item>
        /// <item><description><para><b>out</b>: Outbound traffic.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectList")]
        [Validation(Required=false)]
        public List<string> ObjectList { get; set; }

        /// <summary>
        /// <para>The operation to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>subscribe</b>: Follows the object.</para>
        /// </description></item>
        /// <item><description><para><b>unsubscribe</b>: Unfollows the object.</para>
        /// </description></item>
        /// <item><description><para><b>ignore</b>: Adds the object to the whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>cancelIgnore</b>: Removes the object from the whitelist.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("ObjectOperation")]
        [Validation(Required=false)]
        public string ObjectOperation { get; set; }

        /// <summary>
        /// <para>The type of object to add to the whitelist or follow.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>assetsIp</b>: Asset IP address.</para>
        /// </description></item>
        /// <item><description><para><b>destinationIp</b>: Destination IP address.</para>
        /// </description></item>
        /// <item><description><para><b>destinationPort</b>: Destination port.</para>
        /// </description></item>
        /// <item><description><para><b>destinationDomain</b>: Destination domain name.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>destinationDomain</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123.xxx.251.60</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
