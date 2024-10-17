// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetProxyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the user who enabled the secure access proxy feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        /// <summary>
        /// <para>The nickname of the user who enabled the secure access proxy feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("CreatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The condition cannot be empty!</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The port number used by the HTTPS protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the internal endpoint was enabled. Default value: <b>true</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateEnable")]
        [Validation(Required=false)]
        public bool? PrivateEnable { get; set; }

        /// <summary>
        /// <para>The internal endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dphzmy-5j8oimjsz6ze****.proxy.dms.aliyuncs.com</para>
        /// </summary>
        [NameInMap("PrivateHost")]
        [Validation(Required=false)]
        public string PrivateHost { get; set; }

        /// <summary>
        /// <para>The port number used by the protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("ProtocolPort")]
        [Validation(Required=false)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// <para>The protocol type of the database. Example: MYSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The ID of the secure access proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4**</para>
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public long? ProxyId { get; set; }

        /// <summary>
        /// <para>Indicates whether the public endpoint was enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The public endpoint was enabled.</description></item>
        /// <item><description><b>false</b>: The public endpoint was disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicEnable")]
        [Validation(Required=false)]
        public bool? PublicEnable { get; set; }

        /// <summary>
        /// <para>The public endpoint. A public endpoint is returned no matter whether the public endpoint is enabled or disabled.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the value of the PublicEnable parameter is <b>true</b>, a valid public endpoint that can be resolved by using Alibaba Cloud DNS is returned.</para>
        /// </description></item>
        /// <item><description><para>If the value of the PublicEnable parameter is <b>false</b>, an invalid public endpoint that cannot be resolved by using Alibaba Cloud DNS is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dphzmy-5j8oimjsz6zed7k****.proxy.dms.aliyuncs.com</para>
        /// </summary>
        [NameInMap("PublicHost")]
        [Validation(Required=false)]
        public string PublicHost { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F49D4598-2B3C-5723-865E-2CCB818E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
