// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserPasswordRequest : TeaModel {
        /// <summary>
        /// <para>加密方式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=ModifyTenantUserPassword
        /// &amp;UserName=pay_test
        /// &amp;TenantId=ob2mr3oae0****
        /// &amp;UserPassword=!Aliyun4Oceanbase
        /// &amp;InstanceId=ob317v4uif****
        /// &amp;Common request parameters
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pay_test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>You can call this operation to change the logon password of a specified account in a tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>!Aliyun4Oceanbase</para>
        /// </summary>
        [NameInMap("UserPassword")]
        [Validation(Required=false)]
        public string UserPassword { get; set; }

    }

}
