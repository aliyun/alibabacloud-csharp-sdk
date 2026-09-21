// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAccessKeyLeakDealRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AccessKey leak record.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeAccesskeyLeakList~~">DescribeAccesskeyLeakList</a> operation to obtain this parameter. This parameter and <b>IdList</b> cannot both be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The collection of AccessKey leak record IDs.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// <para>The remarks for handling the AccessKey leak record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The method used to handle the AccessKey leak information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual</b>: Manual handling.</description></item>
        /// <item><description><b>disable</b>: Disable.</description></item>
        /// <item><description><b>add-whitelist</b>: Add to whitelist.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
