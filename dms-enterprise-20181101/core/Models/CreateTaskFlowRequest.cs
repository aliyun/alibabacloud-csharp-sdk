// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateTaskFlowRequest : TeaModel {
        /// <summary>
        /// <para>The name of the task flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dag_Name</para>
        /// </summary>
        [NameInMap("DagName")]
        [Validation(Required=false)]
        public string DagName { get; set; }

        /// <summary>
        /// <para>The description of the task flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zht_test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2**</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public long? ScenarioId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
