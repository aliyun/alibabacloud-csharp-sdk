// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupStructResponseBody : TeaModel {
        /// <summary>
        /// <para>The parent node of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>958****</para>
        /// </summary>
        [NameInMap("GroupFather")]
        [Validation(Required=false)]
        public int? GroupFather { get; set; }

        /// <summary>
        /// <para>The type of the server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the default group</description></item>
        /// <item><description><b>1</b>: other groups</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GroupFlag")]
        [Validation(Required=false)]
        public int? GroupFlag { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>958****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The sequence number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupIndex")]
        [Validation(Required=false)]
        public int? GroupIndex { get; set; }

        /// <summary>
        /// <para>The level of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GroupLevel")]
        [Validation(Required=false)]
        public int? GroupLevel { get; set; }

        /// <summary>
        /// <para>The name of the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestGroupName</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>An array that consists of child groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// <para>The number of servers in the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MachineNum")]
        [Validation(Required=false)]
        public int? MachineNum { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBC6E47-7508-58C9-9E76-528E118C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
