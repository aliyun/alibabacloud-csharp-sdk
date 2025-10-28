// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertDeployGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the instance group.</para>
        /// </summary>
        [NameInMap("DeployGroupEntity")]
        [Validation(Required=false)]
        public InsertDeployGroupResponseBodyDeployGroupEntity DeployGroupEntity { get; set; }
        public class InsertDeployGroupResponseBodyDeployGroupEntity : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3616cdca-4f92-4413-***********</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The version of the deployment package for the application.</para>
            /// <list type="bullet">
            /// <item><description>If the application is deployed, a string of random numbers is returned.</description></item>
            /// <item><description>If the application is not deployed, the return value is empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>f4c50-16ee-a02b-667</b></b>*</para>
            /// </summary>
            [NameInMap("AppVersionId")]
            [Validation(Required=false)]
            public string AppVersionId { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0d247b93-8d62-4e34***********</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The time when the instance group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1573627695779</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the instance group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: the default group.</description></item>
            /// <item><description>1: a group for which canary traffic management is not enabled.</description></item>
            /// <item><description>2: a group for which canary traffic management is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }

            /// <summary>
            /// <para>The ID of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>577f4c50-16ee-43d8-a02b-667*********</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The version of the deployment package that was used to deploy an application in the instance group.</para>
            /// <list type="bullet">
            /// <item><description>If an application is deployed in the instance group, a string of random numbers is returned.</description></item>
            /// <item><description>If no application is deployed in the instance group, the return value is empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>7b93-8d62-4e34</b></b>*******</para>
            /// </summary>
            [NameInMap("PackageVersionId")]
            [Validation(Required=false)]
            public string PackageVersionId { get; set; }

            /// <summary>
            /// <para>The time when the instance group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1573627695779</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3RD9-D3FRE****************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
