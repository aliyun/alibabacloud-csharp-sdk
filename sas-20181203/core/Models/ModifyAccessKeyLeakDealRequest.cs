// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAccessKeyLeakDealRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AccessKey pair leak.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAccesskeyLeakList~~">DescribeAccesskeyLeakList</a> operation to query the ID. You must specify at least one of the Id and <b>IdList</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The IDs of AccessKey pair leaks.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// <para>The remarks that are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The method to handle the AccessKey pair leak. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>manual</b>: manually handle</description></item>
        /// <item><description><b>disable</b>: disable</description></item>
        /// <item><description><b>add-whitelist</b>: add to the whitelist</description></item>
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
