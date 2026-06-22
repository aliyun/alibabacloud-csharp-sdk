// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyGroupPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The new property information of the server group after modification. The following parameters are described:</para>
        /// <list type="bullet">
        /// <item><description><b>groupFlag</b>: The type of the server group. Valid values: <b>0</b> (default group) | <b>1</b> (other group).</description></item>
        /// <item><description><b>groupId</b>: The ID of the server group.</description></item>
        /// <item><description><b>groupIndex</b>: The sorting number of the server group. Sorted in ascending order.</description></item>
        /// <item><description><b>groupName</b>: The name of the server group. Set this parameter to the new name of the server group. The new name must be different from the original name.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain the values of groupFlag and groupId. The values of groupFlag and groupId cannot be modified. Only the value of groupName can be modified.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;groupFlag&quot;:1,&quot;groupId&quot;:8436682,&quot;groupIndex&quot;:1,&quot;groupName&quot;:&quot;example&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

    }

}
