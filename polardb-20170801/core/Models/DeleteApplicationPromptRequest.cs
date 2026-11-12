// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteApplicationPromptRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. The ID must point to an application with mem0 capabilities enabled. You can determine this by checking whether the MemApplicationAttribute returned by DescribeApplicationAttribute is not empty. Applications such as polarclaw, supabase, and polarclawsaas that do not have mem0 enabled do not support prompt operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The prompt ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>papt-f9lajgw765f4fnrzn1</para>
        /// </summary>
        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

    }

}
