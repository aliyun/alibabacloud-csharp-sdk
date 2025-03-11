// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitCleanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database that is scaled out.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds*********</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The scale-out type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>smooth_expand: smooth scale-out</description></item>
        /// <item><description>hot_expand: hot-spot scale-out</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smooth_expand</para>
        /// </summary>
        [NameInMap("ExpandType")]
        [Validation(Required=false)]
        public string ExpandType { get; set; }

        /// <summary>
        /// <para>The job ID of the scale-out task. The value of this parameter is the same as that of the ParentJobId parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the scale-out task. This parameter is returned if you send a request for the smooth scale-out task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ParentJobId")]
        [Validation(Required=false)]
        public string ParentJobId { get; set; }

    }

}
