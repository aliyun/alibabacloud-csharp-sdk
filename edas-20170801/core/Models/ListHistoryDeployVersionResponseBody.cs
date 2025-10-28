// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListHistoryDeployVersionResponseBody : TeaModel {
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
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The information about historical deployment packages.</para>
        /// </summary>
        [NameInMap("PackageVersionList")]
        [Validation(Required=false)]
        public ListHistoryDeployVersionResponseBodyPackageVersionList PackageVersionList { get; set; }
        public class ListHistoryDeployVersionResponseBodyPackageVersionList : TeaModel {
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public List<ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion> PackageVersion { get; set; }
            public class ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3616cdca-4f92-4413-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The time when the deployment package was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573627440892</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deploy</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The unique ID of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>441beb18-da42-44dc-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The version of the application that was released by using the deployment package. This version can be used to call the RollbackApplication operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package.</para>
                /// </summary>
                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                /// <summary>
                /// <para>The deployment mode of the application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>url: The application is deployed by using a JAR or WAR package.</description></item>
                /// <item><description>image: The application is deployed by using an image.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>url</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the deployment package was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573627440892</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package.</para>
                /// </summary>
                [NameInMap("WarUrl")]
                [Validation(Required=false)]
                public string WarUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
