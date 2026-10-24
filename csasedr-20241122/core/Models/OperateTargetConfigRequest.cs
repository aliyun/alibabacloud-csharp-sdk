// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class OperateTargetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The key of the rule switch configuration associated with the policy. It must be the same as the key used in the ListSystemConfigRules query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8b37f46a-72d9-4c8c-bada-2f374a9c3410</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        /// <summary>
        /// <para>The status of the rule switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: Enabled.</description></item>
        /// <item><description><b>del</b>: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of system rule switch identifiers whose status is to be updated. The elements are obtained from the SwitchId returned by ListSystemConfigRules. A maximum of 100 items are supported. The backend updates the items one by one based on the list. The request is rejected if the list is not provided.</para>
        /// </summary>
        [NameInMap("SwitchIdList")]
        [Validation(Required=false)]
        public List<string> SwitchIdList { get; set; }

    }

}
