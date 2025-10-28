// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RestartApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c627c157-560d*******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the elastic compute container (ECC) that corresponds to the ECS instance on which you want to restart the application. You can call the QueryApplicationStatus operation to query the ECC ID. For more information, see <a href="https://help.aliyun.com/document_detail/149394.html">QueryApplicationStatus</a>.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple ECC IDs with commas (,).</description></item>
        /// <item><description>If you leave this parameter empty, the application will be restarted on all the ECS instances deployed with the application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>006c0ea5-5f8d-4398-af1e-**********</para>
        /// </summary>
        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public string EccInfo { get; set; }

    }

}
