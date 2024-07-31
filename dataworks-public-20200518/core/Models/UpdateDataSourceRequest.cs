// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        /// <summary>
        /// The details about the data source. You are not allowed to change the type of the data source. For example, you are not allowed to change the data source type from MaxCompute to MySQL. Examples of details of some common data sources:
        /// 
        /// *   MaxCompute
        /// 
        ///         {
        ///           "accessId": "xssssss",
        ///           "accessKey": "xsaxsaxsa",
        ///           "authType": 2,
        ///           "endpoint": "http://service.odps.aliyun.com/api",
        ///           "project": "xsaxsax",
        ///           "tag": "public"
        ///         }
        /// 
        /// *   MySQL
        /// 
        ///         {
        ///           "database": "xsaxsa",
        ///           "instanceName": "rm-xsaxsa",
        ///           "password": "xsaxsa",
        ///           "rdsOwnerId": "xasxsa",
        ///           "regionId": "cn-shanghai",
        ///           "tag": "rds",
        ///           "username": "xsaxsa"
        ///         }
        /// 
        /// *   RDS
        /// 
        ///         {
        ///           "configType": 1,
        ///           "tag": "rds",
        ///           "database": "xsaxsa",
        ///           "username": "xsaxsa",
        ///           "password": "xssaxsa$32050",
        ///           "instanceName": "rm-xsaxs",
        ///           "rdsOwnerId": "11111111"
        ///         }
        /// 
        /// *   OSS
        /// 
        ///         {
        ///           "accessId": "sssssxx",
        ///           "accessKey": "xsaxaxsaxs",
        ///           "bucket": "xsa-xs-xs",
        ///           "endpoint": "http://oss-cn-shanghai.aliyuncs.com",
        ///           "tag": "public"
        ///         }
        /// 
        /// *   SQL Server
        /// 
        ///         {
        ///           "jdbcUrl": "jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs",
        ///           "password": "sdasda$fs",
        ///           "tag": "public",
        ///           "username": "sxaxacdacdd"
        ///         }
        /// 
        /// *   PolarDB
        /// 
        ///         {
        ///           "clusterId": "pc-sdadsadsa",
        ///           "database": "dsadsadsa",
        ///           "ownerId": "121212122",
        ///           "password": "sdasdafssa",
        ///           "region": "cn-shanghai",
        ///           "tag": "polardb",
        ///           "username": "asdadsads"
        ///         }
        /// 
        /// *   Oracle
        /// 
        ///         {
        ///           "jdbcUrl": "jdbc:oracle:saaa:@xxxxx:1521:PROD",
        ///           "password": "sxasaxsa",
        ///           "tag": "public",
        ///           "username": "sasfadfa"
        ///         }
        /// 
        /// *   MongoDB
        /// 
        ///         {
        ///           "address": "[\\"xsaxxsa.mongodb.rds.aliyuncs.com:3717\\"]",
        ///           "database": "admin",
        ///           "password": "sadsda@",
        ///           "tag": "public",
        ///           "username": "dsadsadas"
        ///         }
        /// 
        /// *   EMR
        /// 
        ///         {
        ///           "accessId": "xsaxsa",
        ///           "emrClusterId": "C-dsads",
        ///           "emrResourceQueueName": "default",
        ///           "emrEndpoint": "emr.aliyuncs.com",
        ///           "accessKey": "dsadsad",
        ///           "emrUserId": "224833315798889783",
        ///           "name": "sasdsadsa",
        ///           "emrAccessMode": "simple",
        ///           "region": "cn-shanghai",
        ///           "authType": "2",
        ///           "emrProjectId": "FP-sdadsad"
        ///         }
        /// 
        /// *   PostgreSQL
        /// 
        ///         {
        ///           "jdbcUrl": "jdbc:postgresql://xxxx:1921/ssss",
        ///           "password": "sdadsads",
        ///           "tag": "public",
        ///           "username": "sdsasda"
        ///         }
        /// 
        /// *   AnalyticDB for MySQL
        /// 
        ///         {
        ///           "instanceId": "am-sadsada",
        ///           "database": "xsxsx",
        ///           "username": "xsxsa",
        ///           "password": "asdadsa",
        ///           "connectionString": "am-xssxsxs.ads.aliyuncs.com:3306"
        ///         }
        /// 
        /// *   HybridDB for PostgreSQL
        /// 
        ///         {
        ///           "connectionString": "gp-xsaxsaxa-master.gpdbmaster.rds.aliyuncs.com",
        ///           "database": "xsaxsaxas",
        ///           "password": "xsaxsaxsa@11",
        ///           "instanceId": "gp-xsaxsaxsa",
        ///           "port": "541132",
        ///           "ownerId": "xsaxsaxsas",
        ///           "username": "sadsad"
        ///         }
        /// 
        /// *   Hologres
        /// 
        ///         {
        ///           "accessId": "xsaxsaxs",
        ///           "accessKey": "xsaxsaxsa",
        ///           "database": "xsaxsaxsa",
        ///           "instanceId": "xsaxa",
        ///           "tag": "aliyun"
        ///         }
        /// 
        /// *   Kafka
        /// 
        ///         {
        ///           "instanceId": "xsax-cn-xsaxsa",
        ///           "regionId": "cn-shanghai",
        ///           "tag": "aliyun",
        ///           "ownerId": "1212121212112"
        ///         }
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The ID of the data source. You can call the [ListDataSources](https://help.aliyun.com/document_detail/2780072.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// The description of the data source.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The environment in which the data source resides. Valid values:
        /// 
        /// *   0: development environment
        /// *   1: production environment
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The status of the data source. This parameter is deprecated. Do not use this parameter.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
