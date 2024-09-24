// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyObjectGroupOperationRequest : TeaModel {
        /// <summary>
        /// <para>The remarks of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The direction of the traffic to which the access control policy applies.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound.</description></item>
        /// <item><description><b>out</b>: outbound.</description></item>
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
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default)</description></item>
        /// <item><description><b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectList")]
        [Validation(Required=false)]
        public List<string> ObjectList { get; set; }

        /// <summary>
        /// <para>The operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ignore</b>: adds the operation object to the whitelist.</description></item>
        /// <item><description><b>cancelIgnore</b>: removes the operation object from the whitelist.</description></item>
        /// <item><description><b>subscribe</b>: follows the operation object.</description></item>
        /// <item><description><b>unsubscribe</b>: unfollows the operation object.</description></item>
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
        /// <para>The type of the operation object.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>assetsIp</b>: the asset IP address.</description></item>
        /// <item><description><b>destinationIp</b>: the destination IP address.</description></item>
        /// <item><description><b>destinationPort</b>: the destination port.</description></item>
        /// <item><description><b>destinationDomain</b>: the destination domain name.</description></item>
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
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123.xxx.251.60</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
