// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordInOutputRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the component action.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSoarTaskAndActions~~">DescribeSoarTaskAndActions</a> operation to query the UUIDs of component actions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0531ff66-dd05-4f24-84bf-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ActionUuid")]
        [Validation(Required=false)]
        public string ActionUuid { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
