// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyGroupPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The new attributes of the server group. You can specify the following parameters to configure the attributes:</para>
        /// <list type="bullet">
        /// <item><description><b>groupFlag</b>: the type of the server group. Valid values: 0 and 1. The value <b>0</b> specifies the Default server group. The value <b>1</b> specifies other server groups.</description></item>
        /// <item><description><b>groupId</b>: the ID of the server group.</description></item>
        /// <item><description><b>groupIndex</b>: no meaning. You can leave this parameter empty.</description></item>
        /// <item><description><b>groupName</b>: the name of the server group. The value is the new name of the server group. The new name cannot be the same as the original name of the server group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain the values of the groupFlag and groupId parameters. You cannot change the value of the groupFlag or groupId parameter. You can change only the value of the groupName parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;groupFlag&quot;:1,&quot;groupId&quot;:8436682,&quot;groupIndex&quot;:,&quot;groupName&quot;:&quot;example&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

    }

}
