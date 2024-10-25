// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. To obtain the application ID, call the ListApplications operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e76f8985-7965-41fc-925b-9648bb6bf650</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The list of data files that you want to distribute. The value must be a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;app01\&quot;,        \&quot;version\&quot;:\&quot;1.0\&quot;,        \&quot;destPath\&quot;:\&quot;/root/installed\&quot;,        \&quot;decompress\&quot;:true,        \&quot;targetDirName\&quot;:\&quot;target01\&quot;,        \&quot;fileMode\&quot;:755,        \&quot;timeout\&quot;:1000    },    {        \&quot;name\&quot;:\&quot;app02\&quot;,        \&quot;version\&quot;:\&quot;1.1\&quot;,        \&quot;destPath\&quot;:\&quot;/tmp/test.txt\&quot;,        \&quot;decompress\&quot;:false    }]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The canary release policy. The value must be a JSON string. You can specify multiple distribution policies. By default, all data files are distributed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;name\&quot;:\&quot;ScheduleToAllByMatchExpressions\&quot;,\&quot;parameters\&quot;:{\&quot;match_expressions\&quot;:[{\&quot;key\&quot;:\&quot;region_id\&quot;,\&quot;operator\&quot;:\&quot;In\&quot;,\&quot;values\&quot;:[\&quot;cn-wuhan-telecom_unicom_cmcc-2\&quot;]}]}}</para>
        /// </summary>
        [NameInMap("DistStrategy")]
        [Validation(Required=false)]
        public string DistStrategy { get; set; }

    }

}
