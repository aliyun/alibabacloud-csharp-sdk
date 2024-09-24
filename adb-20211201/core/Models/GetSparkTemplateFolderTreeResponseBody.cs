// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkTemplateFolderTreeResponseBody : TeaModel {
        /// <summary>
        /// <para>The directory structure of Spark applications, which is in the tree format. Fields in the response parameter:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Uid</b>: the UID of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: the application template type. Valid values: <b>FOLDER</b></para>
        /// </description></item>
        /// <item><description><para><b>Parent</b>: indicates whether a child directory exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no.</description></item>
        /// <item><description><b>-1</b>: yes.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Children</b>: the child directory.</para>
        /// </description></item>
        /// <item><description><para><b>LastModified</b>: the time when applications in the directory are last modified. This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// </description></item>
        /// <item><description><para><b>Name</b>: the name of the directory.</para>
        /// </description></item>
        /// <item><description><para><b>Id</b>: the directory ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{           &quot;Uid&quot;:195813423****,           &quot;Type&quot;:&quot;FOLDER&quot;,          &quot;Parent&quot;:-1,           &quot;Children&quot;:[              {                     &quot;LastModified&quot;:1647853173,               &quot;Uid&quot;:195813423****,                     &quot;Type&quot;:&quot;FOLDER&quot;,                     &quot;Parent&quot;:0,                     &quot;Id&quot;:157,                     &quot;Name&quot;:&quot;t&quot;         }       ],            &quot;Id&quot;:725204,            &quot;Name&quot;:&quot;root&quot;      }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
