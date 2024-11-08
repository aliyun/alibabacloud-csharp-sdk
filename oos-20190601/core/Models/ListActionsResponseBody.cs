// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the actions.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<ListActionsResponseBodyActions> Actions { get; set; }
        public class ListActionsResponseBodyActions : TeaModel {
            /// <summary>
            /// <para>The type of the action.</para>
            /// <ol>
            /// <item><description><para>Atomic actions</para>
            /// <list type="bullet">
            /// <item><description>Atomic.API</description></item>
            /// <item><description>Atomic.Trigger</description></item>
            /// <item><description>Atomic.Control</description></item>
            /// <item><description>Atomic.Embedded</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Cloud product actions</para>
            /// <list type="bullet">
            /// <item><description>Product.ECS</description></item>
            /// <item><description>Product.RDS</description></item>
            /// <item><description>Product.VPC</description></item>
            /// <item><description>Product.FC</description></item>
            /// <item><description>...</description></item>
            /// </list>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::Template</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The time when the action was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReplaceSystemDisk</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::ReplaceSystemDisk</para>
            /// </summary>
            [NameInMap("OOSActionName")]
            [Validation(Required=false)]
            public string OOSActionName { get; set; }

            /// <summary>
            /// <para>The number of times that the action is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Popularity")]
            [Validation(Required=false)]
            public int? Popularity { get; set; }

            /// <summary>
            /// <para>The parameters of the action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;ImageId&quot;: { &quot;Description&quot;: &quot;The mirror ID you will use when resetting the system&quot;, &quot;Type&quot;: &quot;String&quot; }, &quot;InstanceId&quot;: { &quot;Description&quot;: &quot;the instance id that you will handle .&quot;, &quot;Type&quot;: &quot;String&quot; } }</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>The version of the template that corresponds to the action.</para>
            /// <remarks>
            /// <para> For atomic actions, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9154C02-F847-4563-BB6A-6DD01A4F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
