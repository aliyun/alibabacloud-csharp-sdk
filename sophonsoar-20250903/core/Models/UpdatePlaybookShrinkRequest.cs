// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class UpdatePlaybookShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language type for requests and received messages. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Description of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb block</para>
        /// </summary>
        [NameInMap("PlaybookDescription")]
        [Validation(Required=false)]
        public string PlaybookDescription { get; set; }

        /// <summary>
        /// <para>List of input parameter configurations for the playbook.</para>
        /// </summary>
        [NameInMap("PlaybookInputConfigs")]
        [Validation(Required=false)]
        public string PlaybookInputConfigsShrink { get; set; }

        /// <summary>
        /// <para>The name of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_aliyun_alb_process_book</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>List of output parameter configurations for the playbook.</para>
        /// </summary>
        [NameInMap("PlaybookOutputConfigs")]
        [Validation(Required=false)]
        public string PlaybookOutputConfigsShrink { get; set; }

        /// <summary>
        /// <para>Type of input parameters for the playbook.</para>
        /// <list type="bullet">
        /// <item><description><b>template-ip</b>: IP entity.</description></item>
        /// <item><description><b>template-file</b>: File entity.</description></item>
        /// <item><description><b>template-process</b>: Process entity.</description></item>
        /// <item><description><b>template-host</b>: Host entity.</description></item>
        /// <item><description><b>template-domain</b>: Domain entity.</description></item>
        /// <item><description><b>template-container</b>: Container entity.</description></item>
        /// <item><description><b>template-incident</b>: Security incident.</description></item>
        /// <item><description><b>template-alert</b>: Security alert.</description></item>
        /// <item><description><b>custom</b>: Custom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>template-ip</para>
        /// </summary>
        [NameInMap("PlaybookParamType")]
        [Validation(Required=false)]
        public string PlaybookParamType { get; set; }

        /// <summary>
        /// <para>Content of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;58d87b7d-28d9-4f0e-b135-4adc4f1a70e4&quot;,&quot;zIndex&quot;:1,&quot;data&quot;:{&quot;nodeType&quot;:&quot;startEvent&quot;,&quot;appType&quot;:&quot;basic&quot;,&quot;nodeName&quot;:&quot;start&quot;,&quot;icon&quot;:&quot;icon-circle&quot;,&quot;description&quot;:&quot;start&quot;},&quot;position&quot;:{&quot;x&quot;:-440,&quot;y&quot;:-170}},{&quot;id&quot;:&quot;5293c3f9-e1c9-4a49-b0eb-635067dc67e8&quot;,&quot;zIndex&quot;:1,&quot;data&quot;:{&quot;nodeType&quot;:&quot;sequenceFlow&quot;,&quot;appType&quot;:&quot;basic&quot;,&quot;icon&quot;:&quot;icon-upper-right-arrow&quot;,&quot;isRequired&quot;:true},&quot;source&quot;:{&quot;cell&quot;:&quot;58d87b7d-28d9-4f0e-b135-4adc4f1a70e4&quot;},&quot;target&quot;:{&quot;cell&quot;:&quot;f9d6d1f5-b0cd-45b6-93d0-02cd4b2a6fa2&quot;},&quot;vertices&quot;:[]},{&quot;id&quot;:&quot;317dd1be-2d20-460e-977e-1fc936ffb583&quot;,&quot;zIndex&quot;:1,&quot;data&quot;:{&quot;nodeType&quot;:&quot;endEvent&quot;,&quot;appType&quot;:&quot;basic&quot;,&quot;nodeName&quot;:&quot;end&quot;,&quot;icon&quot;:&quot;icon-radio-off-full&quot;,&quot;description&quot;:&quot;end&quot;},&quot;position&quot;:{&quot;x&quot;:-140,&quot;y&quot;:-170}},{&quot;id&quot;:&quot;f9d6d1f5-b0cd-45b6-93d0-02cd4b2a6fa2&quot;,&quot;zIndex&quot;:1,&quot;data&quot;:{&quot;isDebug&quot;:false,&quot;nodeType&quot;:&quot;action&quot;,&quot;appType&quot;:&quot;component&quot;,&quot;nodeName&quot;:&quot;data&quot;,&quot;valueData&quot;:{&quot;outputFields&quot;:&quot;[{\&quot;fieldName\&quot;:\&quot;ip\&quot;,\&quot;fieldValue\&quot;:\&quot;${event.ip}\&quot;}]&quot;},&quot;icon&quot;:&quot;<a href="https://img.alicdn.com/imgextra/i2/O1CN01NCKmL026m1z8o0DeN_!!6000000007703-2-tps-248-248.png%22,%22description%22:%22%22,%22advance%22:%7B%22inputParamMode%22:false,%22onError%22:%22stop_cur_flow%22,%22rspStatusType%22:3,%22rspStatusThreshold%22:0%7D,%22componentName%22:%22DataFormat%22,%22actionName%22:%22formatdata%22%7D,%22position%22:%7B%22x%22:-340,%22y%22:-185%7D%7D,%7B%22id%22:%221c7f0021-fb93-4478-b10f-af78dd5a69d6%22,%22zIndex%22:1,%22data%22:%7B%22nodeType%22:%22sequenceFlow%22,%22appType%22:%22basic%22,%22icon%22:%22icon-upper-right-arrow%22,%22isRequired%22:true%7D,%22source%22:%7B%22cell%22:%22f9d6d1f5-b0cd-45b6-93d0-02cd4b2a6fa2%22%7D,%22target%22:%7B%22cell%22:%22317dd1be-2d20-460e-977e-1fc936ffb583%22%7D,%22vertices%22:%5B%5D%7D%5D">https://img.alicdn.com/imgextra/i2/O1CN01NCKmL026m1z8o0DeN_!!6000000007703-2-tps-248-248.png&quot;,&quot;description&quot;:&quot;&quot;,&quot;advance&quot;:{&quot;inputParamMode&quot;:false,&quot;onError&quot;:&quot;stop_cur_flow&quot;,&quot;rspStatusType&quot;:3,&quot;rspStatusThreshold&quot;:0},&quot;componentName&quot;:&quot;DataFormat&quot;,&quot;actionName&quot;:&quot;formatdata&quot;},&quot;position&quot;:{&quot;x&quot;:-340,&quot;y&quot;:-185}},{&quot;id&quot;:&quot;1c7f0021-fb93-4478-b10f-af78dd5a69d6&quot;,&quot;zIndex&quot;:1,&quot;data&quot;:{&quot;nodeType&quot;:&quot;sequenceFlow&quot;,&quot;appType&quot;:&quot;basic&quot;,&quot;icon&quot;:&quot;icon-upper-right-arrow&quot;,&quot;isRequired&quot;:true},&quot;source&quot;:{&quot;cell&quot;:&quot;f9d6d1f5-b0cd-45b6-93d0-02cd4b2a6fa2&quot;},&quot;target&quot;:{&quot;cell&quot;:&quot;317dd1be-2d20-460e-977e-1fc936ffb583&quot;},&quot;vertices&quot;:[]}]</a></para>
        /// </summary>
        [NameInMap("PlaybookTaskFlow")]
        [Validation(Required=false)]
        public string PlaybookTaskFlow { get; set; }

        /// <summary>
        /// <para>UUID of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f55e76d-b5d5-4720-9cd7-xxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The user ID for the administrator to switch to another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13760*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
