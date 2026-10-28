// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaTemplateServiceStatusResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D47B3A10-CDAC-5412-B2EE-EC9A3DBE9053</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the quota template.</para>
        /// </summary>
        [NameInMap("TemplateServiceStatus")]
        [Validation(Required=false)]
        public GetQuotaTemplateServiceStatusResponseBodyTemplateServiceStatus TemplateServiceStatus { get; set; }
        public class GetQuotaTemplateServiceStatusResponseBodyTemplateServiceStatus : Darabonba.Model {
            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-pG****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the quota template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>-1: Disabled.</para>
            /// </description></item>
            /// <item><description><para>1: Enabled.</para>
            /// </description></item>
            /// <item><description><para>0: Unset.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

        }

    }

}

