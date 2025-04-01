// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetWebshellTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is specified, Cloud Assistant runs the command in the specified container of the instance.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is specified, the command can run only on Linux instances on which Cloud Assistant Agent 2.2.3.344 or later is installed.</para>
        /// <list type="bullet">
        /// <item><description>For information about how to query the version of Cloud Assistant Agent, see <a href="https://help.aliyun.com/document_detail/64921.html">Install Cloud Assistant Agent</a>.</description></item>
        /// <item><description>For information about how to upgrade Cloud Assistant Agent, see <a href="https://help.aliyun.com/document_detail/134383.html">Upgrade or disable upgrades for Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If this parameter is specified, the <c>Username</c> parameter that is specified in a request to call this operation and the <c>WorkingDir</c> parameter that is specified in a request to call the <a href="https://help.aliyun.com/document_detail/64844.html">CreateCommand</a> operation do not take effect. You can run the command only in the default working directory of the container by using the default user of the container. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is specified, only shell scripts can be run in Linux containers. You cannot add a command in the format similar to <c>#!/usr/bin/python</c> at the beginning of a script to specify a script interpreter. For more information, see <a href="https://help.aliyun.com/document_detail/456641.html">Use Cloud Assistant to run commands in containers</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ad-helper</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello-podsdfsdfsdfsdf</para>
        /// </summary>
        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

    }

}
