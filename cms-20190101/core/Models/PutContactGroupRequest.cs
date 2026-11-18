// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutContactGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert contact group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Attendance System Group</para>
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// <para>The names of the alert contacts.</para>
        /// </summary>
        [NameInMap("ContactNames")]
        [Validation(Required=false)]
        public List<string> ContactNames { get; set; }

        /// <summary>
        /// <para>The description of the alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert test</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the subscription feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSubscribed")]
        [Validation(Required=false)]
        public bool? EnableSubscribed { get; set; }

    }

}
