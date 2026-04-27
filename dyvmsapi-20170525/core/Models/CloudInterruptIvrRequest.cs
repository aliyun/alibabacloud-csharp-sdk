// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudInterruptIvrRequest : TeaModel {
        /// <summary>
        /// <para>根据变量名去通道变量中取对应的变量值</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("CheckName")]
        [Validation(Required=false)]
        public string CheckName { get; set; }

        /// <summary>
        /// <para>当checkName代表的变量值与checkValue一致，才打断</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1</para>
        /// </summary>
        [NameInMap("CheckValue")]
        [Validation(Required=false)]
        public string CheckValue { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>通话唯一标识；从通道唯一标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// <para>自定义字段；json字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("UserField")]
        [Validation(Required=false)]
        public string UserField { get; set; }

    }

}
