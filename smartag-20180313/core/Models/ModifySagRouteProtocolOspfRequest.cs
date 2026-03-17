// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagRouteProtocolOspfRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the OSPF area.</para>
        /// <para>Valid values: <b>1 to 2147483647</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public int? AreaId { get; set; }

        /// <summary>
        /// <para>The authentication method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: does not enable authentication.</description></item>
        /// <item><description><b>CLEARTEXT</b>: uses plaintext authentication. You must enter the plaintext password.</description></item>
        /// <item><description><b>MD5</b>: uses MD5 authentication. You must enter the MD5 key ID and the MD5 key.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// <para>The timeout period of OSPF. Unit: seconds.</para>
        /// <para>Valid values: <b>1 to 65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DeadTime")]
        [Validation(Required=false)]
        public int? DeadTime { get; set; }

        /// <summary>
        /// <para>The time interval at which Hello packets are sent. Unit: seconds.</para>
        /// <para>Valid values: <b>1 to 65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HelloTime")]
        [Validation(Required=false)]
        public int? HelloTime { get; set; }

        /// <summary>
        /// <para>The MD5 key value.</para>
        /// <para>Valid values: <b>1 to 47</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if <b>AuthenticationType</b> is set to <b>MD5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Md5Key")]
        [Validation(Required=false)]
        public string Md5Key { get; set; }

        /// <summary>
        /// <para>The ID of the MD5 key.</para>
        /// <para>Valid values: <b>1 to 2147483647</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if <b>AuthenticationType</b> is set to <b>MD5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Md5KeyId")]
        [Validation(Required=false)]
        public int? Md5KeyId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The plaintext password.</para>
        /// <para>The password must be 1 to 8 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <remarks>
        /// <para> This parameter is required only if <b>AuthenticationType</b> is set to <b>CLEARTEXT</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1212****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the router that has OSPF enabled.</para>
        /// <para>Set the value to an IPv4 address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-whfn****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device associated with the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a30***</para>
        /// </summary>
        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

    }

}
