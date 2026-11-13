// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyObjectGroupOperationRequest : TeaModel {
        /// <summary>
        /// <para>The comment for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Comment for batch whitelisting</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The traffic direction controlled by the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound</description></item>
        /// <item><description><b>out</b>: outbound</description></item>
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
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of objects to operate on.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectList")]
        [Validation(Required=false)]
        public List<string> ObjectList { get; set; }

        /// <summary>
        /// <para>The operation to whitelist, remove from the whitelist, follow, or unfollow an object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>subscribe</b>: follow</description></item>
        /// <item><description><b>unsubscribe</b>: unfollow</description></item>
        /// <item><description><b>ignore</b>: add to the whitelist</description></item>
        /// <item><description><b>cancelIgnore</b>: remove from the whitelist</description></item>
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
        /// <para>The type of the object to whitelist or follow for outbound connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>assetsIp</b>: asset IP address</description></item>
        /// <item><description><b>destinationIp</b>: destination IP address</description></item>
        /// <item><description><b>destinationPort</b>: destination port</description></item>
        /// <item><description><b>destinationDomain</b>: destination domain name</description></item>
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
        /// <para>The source IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123.xxx.251.60</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
