// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ReplaceRCInstanceSystemDiskRequest : TeaModel {
        /// <summary>
        /// <para>The image ID that is used when you reinstall the OS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-2zec4lvlhcdkyd13****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-m5ei7b1w38w2l91x****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("IsLocalDisk")]
        [Validation(Required=false)]
        public bool? IsLocalDisk { get; set; }

        /// <summary>
        /// <para>The name of the new key pair. If you do not specify this parameter, you must reset the key pair after the OS is reinstalled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The new logon password of the RDS Custom instance. If you do not specify this parameter, you must reset the logon password after the OS is reinstalled.</para>
        /// <list type="bullet">
        /// <item><description>The value must be 8 to 30 characters in length.</description></item>
        /// <item><description>The value must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Supported special characters include: ( ) \` ~ ! @ # $ % ^ &amp; \* - _ + =</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
