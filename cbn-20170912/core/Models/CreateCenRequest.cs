// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the CEN instance.</para>
        /// <para>The description can be left empty or must be 1 to 256 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the CEN instance.</para>
        /// <para>The name can be left empty or must be 1 to 128 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies the level of CIDR block overlap.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>REDUCED</b> (default): CIDR blocks can overlap but cannot be identical.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REDUCED</para>
        /// </summary>
        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public string ProtectionLevel { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCenRequestTag> Tag { get; set; }
        public class CreateCenRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>The tag key cannot be an empty string. It can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value cannot be empty. It can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to a tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
