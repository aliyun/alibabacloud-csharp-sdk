// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateJvmConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c627c157-560d-*************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group where the application is deployed. You can call the ListDeployGroup operation to query the group ID. For more information, see <a href="https://help.aliyun.com/document_detail/62077.html">ListDeployGroup</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To configure the JVM parameters for an instance group, set this parameter to a specific ID.</para>
        /// </description></item>
        /// <item><description><para>To configure the JVM parameters for an application, leave this parameter empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0afc726e-077e-4357-98b2-db9f7145****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The maximum size of the heap memory. Unit: MB.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified in the group configuration, the value specified in the application configuration is used.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified in the application configuration, the default value is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxHeapSize")]
        [Validation(Required=false)]
        public int? MaxHeapSize { get; set; }

        /// <summary>
        /// <para>The size of the permanent generation heap memory. Unit: MB.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified in the group configuration, the value specified in the application configuration is used.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified in the application configuration, the default value is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        /// <summary>
        /// <para>The initial size of the heap memory. Unit: MB.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified in the group configuration, the value specified in the application configuration is used.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified in the application configuration, the default value is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinHeapSize")]
        [Validation(Required=false)]
        public int? MinHeapSize { get; set; }

        /// <summary>
        /// <para>The custom JVM parameters.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified in the group configuration, the value specified in the application configuration is used.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified in the application configuration, the default value is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-Dproperty=value</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

    }

}
